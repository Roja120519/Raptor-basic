procedure cal is
   raptor_prompt_variable_zzyz : Unbounded_String;
   x : ??_Variable;
   y : ??_Variable;
   op : ??_Variable;
begin
   raptor_prompt_variable_zzyz :="Enter x value";
   Put_Line(raptor_prompt_variable_zzyz);
   Get(x);
   raptor_prompt_variable_zzyz :="enter th ey value";
   Put_Line(raptor_prompt_variable_zzyz);
   Get(y);
   raptor_prompt_variable_zzyz :="Enter the operator";
   Put_Line(raptor_prompt_variable_zzyz);
   Get(op);
   if op="+" then 
      Put_Line("x + y = "+(x+y));
   else
      if op="-" then 
         Put_Line("x - y = "+(x-y));
      else
         if op="*" then 
            Put_Line("x * y = "+(x*y));
         else
            if op="/" then 
               Put_Line("x / y = "+(x/y));
            else
               if op="%" then 
                  Put_Line("x % y = "+(x mod y));
               else
                  if op="^" then 
                     Put_Line("x ^ y = "+(x ** y));
                  else
                  end if;
               end if;
            end if;
         end if;
      end if;
   end if;
end cal;
