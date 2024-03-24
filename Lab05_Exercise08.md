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

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="797" alt="Screenshot 2024-03-24 152110" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/f605583d-8ce0-4c80-b86a-13f6f7333eee">
โปรแกรมสามารถ Build ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex08
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="799" alt="Screenshot 2024-03-24 152253" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/58f6113c-4396-43c6-9501-2a8e6c0fec8e">
โปรแกรมสามารถ Run ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 2+3 = 5, 2*3 = 6 จาก code ใช้ class Calculator เป็น static class เพื่อสร้าง method add และ multiply ที่สามารถเรียกใช้ได้
