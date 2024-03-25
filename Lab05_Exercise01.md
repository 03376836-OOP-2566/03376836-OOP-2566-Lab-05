# Lab 5 Exercise 1

## การสร้าง Class


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex01
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person p = new Person();
System.Console.WriteLine($"Type of p is {p.GetType()}");

class Person
{

}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex01
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![1](https://github.com/Siriratda/03376836-OOP-2566-Lab-05/assets/144195995/e85e85f6-5bc0-4c63-8db8-3b5434e1feb1)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![1 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-05/assets/144195995/442a22f1-d1bf-42d6-a57c-34685c6b8329)

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดงผล Type of p is Person ในโค้ด กรณีนี้ Person ไม่มีอะไรภายในคลาสเลย แต่โปรแกรมยังคงสามารถทำงานได้ไม่มีปัญหา
