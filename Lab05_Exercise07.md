# Lab 5 Exercise 7

## Method with parameter and return value


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex07
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/32105e59-e48a-4b0b-8499-2e2100bf179f)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var adder = new MyProgram();
int x = 2, y = 3;
int add_result = adder.add(x, y);
System.Console.WriteLine($"{x} + {y} = {add_result}");

int i = 2, j = 3;
int multiply_result = adder.multiply(i, j);
System.Console.WriteLine($"{i} x {j} = {multiply_result}");

class MyProgram
{
    public int add(int a, int b)
    {
        return a + b;
    }
    public int multiply(int a, int b)
    {
        return a * b;
    }
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/4bf2d4ad-664a-430f-8778-36367091908a)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex07
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/afc47485-6307-433b-979a-25c8ebea0f4e)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex07
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/ba0eba77-61f7-44ef-adf8-df72cb7b65d6)


7. อธิบายสิ่งที่พบในการทดลอง
   
การทดลองนี้ สร้างอ็อบเจกต์ของคลาส MyProgram ด้วยการใช้คำสั่ง var adder = new MyProgram(); และใช้อ็อบเจกต์ adder เพื่อเรียกใช้เมทอด add และ multiply ในคลาส MyProgram เพื่อทำการบวกและคูณตัวเลขตามลำดับ

ในการทดลองนี้ ใช้ตัวแปร x และ y เพื่อทดสอบการบวก และตัวแปร i และ j เพื่อทดสอบการคูณ

ผลลัพธ์ของการทดลองคือการแสดงผลลัพธ์ของการบวกและการคูณออกทางหน้าจอ ซึ่งแสดงให้เห็นว่าสามารถเรียกใช้เมทอดที่ถูกสร้างในคลาส MyProgram ผ่านอ็อบเจกต์ adder 
ได้อย่างถูกต้อง และได้ผลลัพธ์ที่ถูกต้องจากการทำงานของเมทอดทั้งสองในคลาส MyProgram ที่สร้างขึ้นในการทดลองนี้


