# Lab 5 Exercise 2

## การประกาศสมาชิกในคลาส (fields)


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex02
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
    string name;
    string id;
    int income;
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex02
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="798" alt="Screenshot 2024-03-24 144043" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/f4a0fee5-8cdf-49d6-8400-e4574bf2fa08">
โปรแกรมไม่สามารถ Build ได้เพราะในส่วนของ class (field) ไม่ได้กำหนด public ในการเข้าถึง

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="799" alt="Screenshot 2024-03-24 144241" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/f7a6eb57-8c54-42f3-bd4e-4512227e6bf6">

โปรแกรมไม่สามารถ Run ได้เพราะในส่วนของ class (field) ไม่ได้กำหนด public ในการเข้าถึง

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมเกิด Error เพราะไม่ได้กำหนดการเข้าถึง field ต้องกำหนดเป็น public ก่อนถึงจะสามารถ Run ได้
