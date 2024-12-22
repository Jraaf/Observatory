'use client';
import { authApi } from '@/app/api/auth/auth-api';

import { useForm } from 'react-hook-form';
import { Input } from '@/components/ui/input';
import { Button } from '@/components/ui/button';

import {
  Form,
  FormField,
  FormItem,
  FormLabel,
  FormMessage,
} from '@/components/ui/form';
import { zodResolver } from '@hookform/resolvers/zod';
import { useRouter } from 'next/navigation';
import { TSignUp, SignUpSchema } from '@/lib/schemas/auth.schemas';
import { useCommonToast } from '@/components/ui/toast/use-common-toast';
import { PasswordInput } from '@/components/ui/password-input';
import { setAuthToken } from '@/app/api/auth/server-auth-api';

export const RegisterForm = () => {
  const { push } = useRouter();
  const { toastError, toastSuccess } = useCommonToast();
  const form = useForm<TSignUp>({
    resolver: zodResolver(SignUpSchema),
    defaultValues: {
      password: '',
      username: '',
      confirmPassword: '',
    },
    mode: 'onSubmit',
  });
  async function onSubmit(values: TSignUp) {
    try {
      const { data } = await authApi.register({
        username: values.username,
        password: values.password,
        isAdmin: false,
      });

      await setAuthToken(data.accessToken);
      toastSuccess('Account created successfully');
      push('/');
    } catch (error) {
      toastError(error);
    }
  }

  return (
    <Form {...form}>
      <form
        onSubmit={form.handleSubmit(onSubmit)}
        className='flex w-full max-w-[440px] flex-col gap-5'
      >
        <FormField
          control={form.control}
          name='username'
          render={({ field }) => (
            <FormItem>
              <FormLabel className='text-sm font-normal'>Username</FormLabel>
              <Input {...field} placeholder='Username' />
              <FormMessage />
            </FormItem>
          )}
        />

        <FormField
          control={form.control}
          name='password'
          render={({ field }) => (
            <FormItem>
              <FormLabel className='text-sm font-normal'>Password</FormLabel>
              <PasswordInput placeholder='Password' {...field} />
              <FormMessage />
            </FormItem>
          )}
        />

        <FormField
          control={form.control}
          name='confirmPassword'
          render={({ field }) => (
            <FormItem>
              <FormLabel className='text-sm font-normal'>
                Confirm Password
              </FormLabel>
              <PasswordInput {...field} placeholder='Confirm Password' />
              <FormMessage />
            </FormItem>
          )}
        />

        <Button
          type='submit'
          className='w-full'
          disabled={form.formState.isSubmitting}
        >
          Sign Up
        </Button>
      </form>
    </Form>
  );
};
