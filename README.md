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

1. Retrieving the current status of a specific **Battery**:

**GET:** https://rocketapi.azurewebsites.net/api/battery/69 - *(69 the battery id)*

2. Changing the status of a specific **Battery**:

**PUT:** https://rocketapi.azurewebsites.net/api/battery/69 - *(69 the battery id)*

Select: >Body >raw >JSON

    {
        "id": 69,
        "building_id": 69,
        "employee_id": 2,
        "battery_type": "Corporate",
        "status": "active"
    }

To change the status: "status": "active" or "inactive"  and pres **SEND**

Response:

**The status of the Battery Id: 69 as been changed satisfactorily to: inactive**

To check the change, go to the 1 question.

3. Retrieving the current status of a specific **Column**:

**GET:** https://rocketapi.azurewebsites.net/api/column/69 - *(69 the battery id)*


4. Changing the status of a specific **Column**:

**PUT:** https://rocketapi.azurewebsites.net/api/column/69 - *(69 the battery id)*

Select: >Body >raw >JSON

    {
        "id": 69,
        "column_type": "Residential",
        "number_floors": 6,
        "status": "inactive",
        "info": "Auxilium ipsa nihil textilis ultio.",
        "notes": "Auxilium ipsa nihil textilis ultio.",
        "battery_id": 24
    }

To change the status: "status": "active" or "inactive"  and pres **SEND**

Response:

**The status of the Column Id: 69 as been changed satisfactorily to: inactive**

To check the change, go to the 3 question.

5. Retrieving the current status of a specific **Elevator**:

**GET:** https://rocketapi.azurewebsites.net/api/elevator/69 - *(69 the elevator id)*

6. Changing the status of a specific **Elevator**:

**PUT:** https://rocketapi.azurewebsites.net/api/elevator/69 - *(69 the elevator id)*

Select: >Body >raw >JSON

  {
    "id": 69,
    "column_id": 20,
    "status": "active"
  }

To change the status: "status": "active" or "inactive"  and pres **SEND**

Response:

**The status of the Elevator Id: 69 as been changed satisfactorily to: inactive**

To check the change, go to the 5 question.

7. Retrieving a list of **Elevators** that are not in operation at the time of the request:

**GET:** https://rocketapi.azurewebsites.net/api/elevator/notinoperation

8. Retrieving a list of **Buildings** that contain at least one battery, column or elevator requiring intervention:

**GET:** https://rocketapi.azurewebsites.net/api/building/intervention

9. Retrieving a list of **Leads** created in the last 30 days who have not yet become customers:

**GET:** https://rocketapi.azurewebsites.net/api/lead/notcustomers


