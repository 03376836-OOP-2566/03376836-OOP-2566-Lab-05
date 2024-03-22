# Lab 5 Exercise 3

## การควบคุมการเข้าถึงสมาชิกในคลาส (fields)


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/d97ee8b4-08f1-4887-96af-0cad6cb0dffc)

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
    public string? name;
    public string? id;
    public int income;
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/672fe188-3ec5-4b87-b304-3acf266ffbe6)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex03
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/c906cbcf-4681-41f9-9730-12798edebf96)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/0a958899-346d-43f3-8ff0-41022a476322)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/85902f4c-0c3c-419d-a91a-4b466e208090)


7. อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้ เราสร้างอ็อบเจกต์ของคลาส Person และกำหนดค่าให้กับสมบัติ name, id, และ income ของอ็อบเจกต์ p

โดยในคลาส Person เราได้ทำการประกาศสมบัติ name และ id ให้มีประเภท string? ซึ่งหมายถึงสามารถเก็บค่า null 
ได้ ในขณะที่สมบัติ income มีประเภท int ซึ่งไม่สามารถเก็บค่า null ได้ เนื่องจากไม่ได้ใส่เครื่องหมาย ? ตามหลังประเภทข้อมูล
การทดลองนี้ เราสร้างอ็อบเจกต์ของคลาส Person และกำหนดค่าให้กับสมบัติ name, id, และ income ของอ็อบเจกต์ p

โดยในคลาส Person เราได้ทำการประกาศสมบัติ name และ id ให้มีประเภท string? ซึ่งหมายถึงสามารถเก็บค่า null 
ได้ ในขณะที่สมบัติ income มีประเภท int ซึ่งไม่สามารถเก็บค่า null ได้ เนื่องจากไม่ได้ใส่เครื่องหมาย ? ตามหลังประเภทข้อมูล
จากผลลัพธ์ที่แสดง เราเห็นได้ว่าสมบัติ name และ id สามารถเก็บค่า null ได้ เนื่องจากได้ประกาศให้มีประเภท string? ในขณะที่สมบัติ income 
ไม่สามารถเก็บค่า null ได้ เนื่องจากมีประเภท int ซึ่งไม่ได้ประกาศให้เป็น nullable ด้วยเครื่องหมาย ?

การแสดงผลตามภาพด้านบน

Type of p is Person
p.name = Rambo    type = System.String
p.id = 1987    type = System.String
p.income = 2500    type = System.Int32
