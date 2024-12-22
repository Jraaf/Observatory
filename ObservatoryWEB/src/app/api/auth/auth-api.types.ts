export interface LoginBody {
  username: string;
  password: string;
}
export interface RegisterBody {
  email: string;
  username: string;
  password: string;
  isAdmin: boolean;
}

export interface AuthResponse {
  id: number;
  username: string;
  accessToken: string;
}

export enum AuthToken {
  AccessToken = 'access_token',
}
