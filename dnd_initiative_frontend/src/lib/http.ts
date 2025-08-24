import axios from "axios";

export const http = axios.create({
  baseURL: import.meta.env.API_URL ?? "http://localhost:8080", // dev default
  // withCredentials: true, // if you use cookies/sessions
});

export default http;
