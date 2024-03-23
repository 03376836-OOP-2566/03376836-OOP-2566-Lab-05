# Lab 5 Exercise 7

## Method with parameter and return value


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex07
```
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

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex07
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="646" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/892fa353-eb73-4fd3-b8d3-c3581e57d507">

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex07
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="683" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/c2a108d4-67ae-4585-bdf6-59c0e54ef62b">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 2+3 = 5, 2*3= 6 มีการเรียกใช้ method จาก add และ multiply และ return ค่ากลับไปให้ int a , int b
