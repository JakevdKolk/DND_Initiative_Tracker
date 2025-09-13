import http from "../http";
import type { UserList } from "@/types/user";

// optionally set a baseURL somewhere central (vite proxy or full URL)
// axios.defaults.baseURL = "/";

export async function getUsers(): Promise<UserList[]> {
  const { data } = await http.get<UserList[]>("/api/users");
  console.log( 'data' , data);
  return data;
}
