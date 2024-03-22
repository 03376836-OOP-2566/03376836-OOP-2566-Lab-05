# Lab 5 Exercise 8

## Static Class


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex08
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/c6742f69-710f-49ba-9dd1-355ac04e365d)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/0b10addd-0111-4446-b114-2e63c292518a)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex08
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/35355795-a36d-488c-9abd-821d49a6e9f1)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex08
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/059d133c-195f-44b8-a961-c73446178b72)


7. อธิบายสิ่งที่พบในการทดลอง

ในการทดลองนี้เรามีการสร้างคลาสชื่อว่า Calculator ซึ่งเป็นคลาสที่มีเมทอดสำหรับการบวกและคูณเลขจำนวนเต็ม โดยในคลาส Calculator มีเมทอด add และ multiply เพื่อทำการบวกและคูณตัวเลขตามลำดับที่กำหนด

ในการทดลองนี้ เราใช้ตัวแปร x และ y เพื่อทดสอบการบวก และตัวแปร i และ j เพื่อทดสอบการคูณ

ผลลัพธ์ของการทดลองคือการแสดงผลลัพธ์ของการบวกและการคูณออกทางหน้าจอ ซึ่งแสดงให้เห็นว่าการใช้เมทอดที่สร้างในคลาส Calculator ให้ทำงานได้อย่างถูกต้องโดยการเรียกใช้งานผ่านอ็อบเจกต์ของคลาสนั้น ๆ ในการทดลองนี้ได้แสดงให้เห็นถึงการทำงานของเมทอดและการสร้างอ็อบเจกต์ในภาษา C#

