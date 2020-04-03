# <b>A .NET Core API deployed on Microsoft Azure</b>

# <b>Rocket Elevator Restful Api</b>

**Week 8 - Offer Services on the Internet** 

**Team:** 

>1. Ukeme Ekpenyong (Team Leader)
>2. Anna Chowattanakul
>3. Younes Bekkali
>4. David Hunter
>5. Jorge Chavarriaga


*To answer the 9 questions with Postman:*

1. [Retrieving the current status of a specific Battery:](https://rocketapi.azurewebsites.net/api/battery/69)

**GET:** https://rocketapi.azurewebsites.net/api/battery/69 - *(69 the battery id)*

2. Changing the status of a specific Battery:

**PUT:** https://rocketapi.azurewebsites.net/api/battery/69 - *(69 the battery id)*

Select: >Body >raw >JSON

    {
        "id": 69,
        "building_id": 69,
        "employee_id": 2,
        "battery_type": "Corporate",
        "status": "active"
    }


