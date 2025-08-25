<script setup lang="ts">
import { ref, onMounted } from "vue";
import type { AxiosError } from "axios";
import type { User } from "@/types/user";
import { getUsers } from "../lib/api/user.ts"

const users = ref<User[] | null>(null);
const loading = ref(true);
const error = ref<string | null>(null);

onMounted(async () => {
  try {
    users.value = await getUsers();
  } catch (err) {
    const e = err as AxiosError<any>;
    error.value = (e.response?.data as any)?.message ?? e.message;
  } finally {
    loading.value = false;
  }
});
</script>

<template>
  <div class="p-4">
    <p v-if="loading">Loading users…</p>
    <p v-else-if="error" class="text-red-600">Error: {{ error }}</p>

    <ul v-else>
      <li v-for="u in users" :key="u.id">
        {{ u.name  }}
        /
        {{ u.role.name }}
      </li>
    </ul>
  </div>
</template>
