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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-05/assets/144195708/79ee0e48-497e-4c31-b814-2ac4b5f87e34)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex07
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-05/assets/144195708/9ed760f8-048f-4dc7-9137-e8f81e701b9f)


7. อธิบายสิ่งที่พบในการทดลอง โปรแกรมจะแสดงผล 2+3 = 5, 2*3= 6 มีการเรียกใช้ method จาก add และ multiply 
และ return ค่ากลับไปให้ int a , int b 


