# Lab 5 Exercise 6

## Method with parameter 


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex06
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var mc = new MyClass();
mc.DisplayParam(3, 4);
class MyClass
{
    public void DisplayParam(int a, int b)
    {
        System.Console.WriteLine($"a = {a}, b = {b}");
    } 
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex06
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![6](https://github.com/Siriratda/03376836-OOP-2566-Lab-05/assets/144195995/75856447-cc92-4ed0-a410-ef0cc8bb0746)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![6 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-05/assets/144195995/d98ccb53-894e-4a00-b5fd-e5cb2ddb3cbf)

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล a = 3, b = 4 เพราะการกำหนด Method ด้วย parameter จากเรียกใช้ DisplayParam
var mc = new MyClass();
mc.DisplayParam(3, 4);
