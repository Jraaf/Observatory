'use client';

import useAuth from '@/lib/hooks/useAuth';
import { UserMenu } from './UserMenu';
import { AuthButtons } from './AuthButtons';
import { TelescopeIcon } from 'lucide-react';
import Link from 'next/link';

export const Header = () => {
  const { user } = useAuth();

  return (
    <header className='bg-background-darker fixed z-10 my-2 w-full'>
      <div className='mx-auto flex h-full max-w-[1280px] items-center justify-between gap-4 px-4 py-1'>
        <Link
          href='/'
          className='flex w-full cursor-pointer items-center gap-4'
        >
          <TelescopeIcon />
          <h2 className='text-xl font-semibold md:text-2xl'>Observatory</h2>
        </Link>
        {user ? <UserMenu /> : <AuthButtons />}
      </div>
    </header>
  );
};
