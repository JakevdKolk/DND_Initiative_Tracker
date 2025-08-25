import http from "../http";
import type { User } from "@/types/user";

// optionally set a baseURL somewhere central (vite proxy or full URL)
// axios.defaults.baseURL = "/";

export async function getUsers(): Promise<User[]> {
  const { data } = await http.get<User[]>("/api/users");
  console.log( 'data' , data);
  return data;
}
