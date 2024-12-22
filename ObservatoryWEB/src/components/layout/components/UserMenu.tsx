import { FC } from 'react';
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import { logout } from '@/app/api/auth/server-auth-api';
import useAuth from '@/lib/hooks/useAuth';
import Link from 'next/link';

export const UserMenu: FC = () => {
  const { user } = useAuth();
  return (
    <DropdownMenu>
      <DropdownMenuTrigger>
        <h2 className='font-bold'>{user?.username}</h2>
      </DropdownMenuTrigger>
      <DropdownMenuContent className='text-xl'>
        <DropdownMenuItem asChild className='cursor-pointer p-3 text-xl'>
          <div onClick={async () => await logout()}>Sign out</div>
        </DropdownMenuItem>
        <DropdownMenuItem asChild className='cursor-pointer p-3 text-xl'>
          <Link href={`/profile/${user?.id}`}>Profile</Link>
        </DropdownMenuItem>
      </DropdownMenuContent>
    </DropdownMenu>
  );
};
