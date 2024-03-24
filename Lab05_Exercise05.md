# Lab 5 Exercise 5

## simple Method


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex05
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var myObj = new MyClass();
myObj.Info();

class MyClass
{
    int F1;
    string F2;
    int F3 = 100;
    string F4 = "ASDF";

    public void Info()
    {
        System.Console.WriteLine($"Default integer      F1 = {F1}");  //Implicit fields initialization
        System.Console.WriteLine($"Default string       F2 = {F2}");

        System.Console.WriteLine($"Initialized integer  F3 = {F3}");  //Explicit field initialization
        System.Console.WriteLine($"Initialized string   F4 = {F4}");
    } 
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex05
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="797" alt="Screenshot 2024-03-24 145548" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/b28352ca-31c0-48cc-8517-cf4f65fd27e3">
โปรแกรมสามารถ Build ได้ โดยโปรแกรมจะแทนค่าว่างในชนิดต่างๆ ที่ไม่ได้มีการระบุค่าไว้ให้เป็นค่าเริ่ม

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="800" alt="Screenshot 2024-03-24 150110" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-05/assets/144196049/59edc138-319d-491f-a232-07ae4c00cd63">
โปรแกรมสามารถ Run ได้ โดยโปรแกรมจะแทนค่าว่างในชนิดต่างๆ ที่ไม่ได้มีการระบุค่าไว้ให้เป็นค่าเริ่มต้น

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล F1 = 0 F2 = null ตามชนิด Type เป็น Implicit fields initialization เพราะไม่ได้กำหนดค่าและโปรแกรมจะแสดงผล F3 = 100 F4 = ASDF ตามชนิด Type เป็น Explicit field initialization เพราะกำหนดค่าไว้แล้ว โดยมีการกำหนด Method คือ myObj.Info() ผลลัพธ์ที่ได้จากการเรียก myObj.Info() จะแสดงค่าเริ่มต้นและค่าที่ถูกกำหนดไว้ใน field ต่าง ๆ
