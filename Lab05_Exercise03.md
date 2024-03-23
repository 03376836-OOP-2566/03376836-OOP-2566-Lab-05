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

<img width="580" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/706af099-c43d-4619-b5e8-0ef897148cd9">

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="521" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-05/assets/144195963/4dbda0f0-91ce-4920-8023-ad2f6dec9fe7">


7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะทำการแสดงผลค่าที่เรากำหนดเข้าไปเช่น p.id=1987 พร้อมระบุชนิด Type ตามลำดับ
