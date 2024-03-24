# Lab 5 Exercise 3

## การควบคุมการเข้าถึงสมาชิกในคลาส (fields)


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex03
```
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

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex03
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="799" alt="Screenshot 2024-03-24 144518" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/733741bf-c91c-4b99-b491-cc90128c9021">
โปรแกรมสามารถ Build ได้เพราะในส่วนของ class (field) ได้กำหนด public ในการเข้าถึง

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="799" alt="Screenshot 2024-03-24 144610" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/cce18719-f1ba-4e58-bc7d-9cfff1570bf1">
โปรแกรมสามารถ Run ได้เพราะในส่วนของ class (field) ได้กำหนด public ในการเข้าถึง

7. อธิบายสิ่งที่พบในการทดลอง

โปแกรมจะแสดงผลค่าที่เรากำหนดเข้าไปเช่น p.name=Rambo พร้อมระบุชนิด Type ตามลำดับ
