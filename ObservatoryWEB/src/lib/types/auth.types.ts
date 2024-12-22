export interface User {
  id: string;
  email: string;
  username: string;
  isAdmin: boolean;
}

export interface Session {
  user: User | null;
  loading: boolean;
}
