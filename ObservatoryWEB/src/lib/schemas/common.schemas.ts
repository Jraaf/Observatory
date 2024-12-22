import { z } from 'zod';

export const emailSchema = z
  .string({ required_error: 'Введіть пошту' })
  .email({ message: 'Це не є поштовою адресою' })
  .transform((value) => value.trim());

export const usernameSchema = z
  .string({ required_error: `Введіть ім'я/псевдонім` })
  .min(2, 'Не коротше 2 символів')
  .max(100, 'Не довше 100 символів')
  .transform((value) => value.trim());
