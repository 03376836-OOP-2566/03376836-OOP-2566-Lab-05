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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-05/assets/144195555/ec4a10cc-112b-4d48-83da-0fae0b8117f7)
### โปรแกรมสามารถ Build ได้เพราะเป็นการสร้าง object และแสดงชนิดของ object ได้ถูกต้อง
5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-05/assets/144195555/103a05f2-7d73-4391-b14d-6708a8201ca7)
### โปรแกรมสามารถ Run ได้เพราะเป็นการสร้าง object และแสดงชนิดของ object ได้ถูกต้อง

7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดงผลข้อความ Type of p is Person ใน code กรณีนี้, Person คือคลาสที่ไม่มีอะไรภายในเลย แต่โปรแกรม C# ยังคงรับรู้คลาสนี้และไม่มีปัญหา

