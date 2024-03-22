# Lab 5 Exercise 1

## การสร้าง Class


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex01
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/e014a5f7-f9c4-4476-be7f-96601b204f81)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person p = new Person();
System.Console.WriteLine($"Type of p is {p.GetType()}");

class Person
{

}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/3b8bd81a-5f68-44ba-a531-21de64ec9191)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex01
```


4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/c82df72a-437c-438e-bb96-caf7338eb9be)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex01
```


6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/20a90819-1745-40ed-a87c-c10f9a2d9d2e)

7. อธิบายสิ่งที่พบในการทดลอง
   
จะเห็นว่ามีการ แสดงผลคำสั่งออกทางหน้าจอเป็น dotnet run --project Lab05_Ex01

Type of p is Person

โดยการแสดงผลของคำสั่งในโค้ดของ C# เป็นการ สร้างตัวแปร p ที่เป็นอ็อบเจกต์ของคลาส Person และพิมพ์ประเภทของอ็อบเจกต์ p ออกทางหน้าจอ
ผลลัพธ์ที่ได้ก็จะเป็น  Type of p is <ชื่อ namespace>.Person
โดย <ชื่อ namespace> คือชื่อของ namespace ที่คลาส Person ถูกประกาศ
ก็จะอธิบายได้ว่าเป็นกานแสดงผลของโปรเจ็ค Lab05_Ex01 โดยแสดงผลของตัวแปล   p ที่เป็นอ็อบเจกต์ของคลาส Person และพิมพ์ประเภทของอ็อบเจกต์ p ออกทางหน้าจอ
จะผลลัพธ์ที่เป็น  Type of p is Person ออกมาจากการแสดงผลลัพธ์ของคำสั่ง


