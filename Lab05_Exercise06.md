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
<img width="799" alt="Screenshot 2024-03-24 150947" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/6274c677-dbeb-4055-96ee-49f091730a93">
โปรแกรมสามารถ Build ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="800" alt="Screenshot 2024-03-24 151028" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/75bc4a8e-7f5d-42a0-a5fc-1461cc7549a6">
โปรแกรมสามารถ Run ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล a = 3, b = 4 เพราะการกำหนด Method ด้วย parameter จากเรียกใช้ DisplayParam

 var mc = new MyClass();
 
 mc.DisplayParam(3, 4);
