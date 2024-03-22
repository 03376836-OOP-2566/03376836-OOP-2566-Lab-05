# Lab 5 Exercise 2

## การประกาศสมาชิกในคลาส (fields)


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/6e7f1597-53f1-4070-a8c8-1f3da8df4382)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person p = new Person();
p.name = "Rambo";
p.id = "1987";
p.income = 2500;
System.Console.WriteLine($"Type of p is {p.GetType()}");
System.Console.WriteLine($"p.name = {p.name}\ttype = {p.name.GetType()}");
System.Console.WriteLine($"p.id = {p.id}\ttype = {p.id.GetType()}");
System.Console.WriteLine($"p.income = {p.income}\ttype = {p.income.GetType()}");

class Person
{
    string name;
    string id;
    int income;
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/fdbe8e77-056b-4620-9518-1e02cf7e9c71)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex02
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/8d1b7495-70a1-4d6c-a43b-0491d1f30c4a)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/72636845-f3a4-4dfe-b8e9-27accb48e12f)



6. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/a1ab98cf-45d1-4f5b-a3ec-a5ac885eabac)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/d689da52-b045-486e-82f1-26e86b591f26)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/a4be766b-2a8b-478c-87e1-2ea6e192b573)


7. อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้ มีสร้างอ็อบเจกต์ของคลาส Person ด้วยการใช้คำสั่ง Person p = new Person(); และกำหนดค่าให้กับสมบัติ name, id, และ income ของอ็อบเจกต์ p

คลาส Person ถูกกำหนดให้มีสมบัติ name, id, และ income โดยไม่ได้กำหนดการเข้าถึงเป็น public ซึ่งหมายความว่าสมบัติเหล่านี้จะมีการเข้าถึงเฉพาะภายในคลาส Person เท่านั้น

ผลลัพธ์ของการทดลองคือการแสดงประเภทของอ็อบเจกต์ p และแสดงค่าของแต่ละสมบัติพร้อมกับประเภทของแต่ละสมบัติ ทำให้เห็นว่าสมบัติ name, id, และ income
 มีประเภทข้อมูลตามลำดับเป็น string, string, และ int ตามที่กำหนดในคลาส Person
แต่เหมือนว่าจะมีการกำหนดอะไรบ้างอย่างของคำสั่งที่ผิดพลาดอยู่เพราะไม่มีการแสดงผลของคำสั่งที่ระบุไว้ในคำสั่งออกมาเลย เหมือนว่าการแสดงผลทางข้อมูลจะผิดพลาด
