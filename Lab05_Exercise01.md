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

<img width="555" alt="Screenshot 2024-03-24 020944" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/5eb719f7-60d9-4ff1-899a-cdba9a55c912">


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="416" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/b1e6bf73-f36c-4ec9-8687-41548cf24047">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดงผลข้อความ Type of p is Person ใน code กรณีนี้, Person คือคลาสที่ไม่มีอะไรภายในเลย แต่โปรแกรม C# ยังคงรับรู้คลาสนี้และไม่มีปัญหา
