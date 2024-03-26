# Lab 5 Exercise 6

## Static Class


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex08
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
int x = 2, y = 3;
int add_result = Calculator.add(x, y);
System.Console.WriteLine($"{x} + {y} = {add_result}");

int i = 2, j = 3;
int multiply_result = Calculator.multiply(i, j);
System.Console.WriteLine($"{i} x {j} = {multiply_result}");

public static class Calculator
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int multiply(int a, int b)
    {
        return a * b;
    }
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex08
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/a5feec83-4a1f-4c1d-967c-c20accb7e271)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex08
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/a92f0487-5afe-4abf-b8fa-6c70e718624d)


7. อธิบายสิ่งที่พบในการทดลอง
   - มีการสร้างclass calculator ที่มีmethodคือ add(int a , int b ) และ multiply(int a , int b) เพื่อทำกาารบวกและคูณกัน 


