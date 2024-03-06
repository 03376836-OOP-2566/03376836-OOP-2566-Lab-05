## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-05/assets/144196505/03a396c6-53f3-4795-9c33-ef40bcf2da9f)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-05/assets/144196505/7c8486db-bd2c-434d-9c04-e61bcf443892)

## อธิบายสิ่งที่พบในการทดลอง
เกิด Error เพราะไม่ได้กำหนดการเข้าถึง field 
```
class Person
{
    string name;
    string id;
    int income;
}
```
class Person ไม่ได้ถูกกำหนดสิทธิ์เป็น public ทำให้สามารถเข้าถึงได้จากภายนอก
