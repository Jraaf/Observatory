'use client';

import { HeaderMenu } from './HeaderMenu';
import { LogoIcon } from './Logo';
import useAuth from '@/lib/hooks/useAuth';
import { UserMenu } from './UserMenu';
import { AuthButtons } from './AuthButtons';
import { HeaderSearch } from './HeaderSearch';
import { Button } from '@/components/ui/button';
import { TelescopeIcon } from 'lucide-react';

export const Header = () => {
  const { user } = useAuth();

  return (
    <header className='bg-background-darker fixed z-10 w-full my-2'>
      <div className='mx-auto flex h-full max-w-[1280px] items-center justify-between gap-4 px-4 py-1'>
        <div className='flex w-full items-center gap-4'>
          <TelescopeIcon />

          <h2 className='font-semibold text-xl md:text-2xl '>Observatory</h2>
          </div>
        <div className='flex items-center gap-2'>
          {false ? <UserMenu /> : <AuthButtons />}
          <HeaderMenu />
        </div>
      </div>
    </header>
  );
};
