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
<img width="797" alt="Screenshot 2024-03-24 143454" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/77e9bd34-26d0-4b95-acf6-4c7c4e23fac5">
โปรแกรมสามารถ Build ได้เพราะเป็นการสร้าง object และแสดงชนิดของ object ได้ถูกต้อง

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="797" alt="Screenshot 2024-03-24 143730" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/c0f7a357-eac1-47d7-9493-56c99ed7f356">

โปรแกรมสามารถ Run ได้เพราะเป็นการสร้าง object และแสดงชนิดของ object ได้ถูกต้อง

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดงผลข้อความ Type of p is Person ใน code กรณีนี้, Person คือคลาสที่ไม่มีอะไรภายในเลย แต่โปรแกรม C# ยังคงรับรู้คลาสนี้และไม่มีปัญหา
