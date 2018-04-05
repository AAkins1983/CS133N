IsComposite (someNumber)

   composite = false

   if someNumber = 1 then

      composite = false

   else if someNumber = 2 then

      composite = false

   else

      divisor = 2

      while divisor < someNumber and composite = false

         if someNumber is divisible by divisor then

             composite = true

         else

             divisor = divisor + 1

         end if

      end while

   end if

   return composite

end IsComposite