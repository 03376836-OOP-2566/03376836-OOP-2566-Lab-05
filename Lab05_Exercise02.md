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

![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-05/assets/144195555/79d235fa-b142-4f64-8d96-3a456bcb1d54)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-05/assets/144195555/72163cc8-1ac9-472c-8392-78338d300bbf)


7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมเกิด Error เพราะไม่ได้กำหนดการเข้าถึง field ต้องกำหนดเป็น public ก่อนถึงจะสามารถ Run ได้

