# <b>A .NET Core API deployed on Microsoft Azure</b>
# <b>Rocket Elevator Restful Api</b>

<b>**Week 13 - Mobile App ** by Anna Chowattanakul</b>
<b>Here are the commands for the RESTFUL API</b>

1. To see a list of active elevators
   https://annachowattanakulapi.azurewebsites.net/api/elevator/active

2. To see a list of inactive elevators
   https://annachowattanakulapi.azurewebsites.net/api/elevator/notinoperation

3. To change the status of elevator to active
   https://localhost:5001/api/elevator/2/active
   https://annachowattanakulapi.azurewebsites.net/api/elevator/2/active

4. To change the status of elevator to inactive
   https://localhost:5001/api/elevator/2/inactive
   https://annachowattanakulapi.azurewebsites.net/api/elevator/2/inactive
   
5. To verify employee's email (for login)
   https://localhost:5001/api/employee/[email]
   https://annachowattanakulapi.azurewebsites.net/api/employee/[email]
  
   The link gives you a 200 or 404 status   
   example: https://annachowattanakulapi.azurewebsites.net/api/employee/test@test.ca
   
6. To see the list of all employees
   https://annachowattanakulapi.azurewebsites.net/api/employee/all


**Week 9 - Consolidation ** by Anna Chowattanakul

Here are the commands for the RESTFUL API:
1. To see all the interventions                               
   https://localhost:5001/api/intervention/all
   GET: api/intervention/all                               
   https://annachowattanakulapi.azurewebsites.net/api/intervention/all



2. To get an intervention by id                               
   https://localhost:5001/api/internvetion/2 
   GET: api/intervention/(id)  
   https://annachowattanakulapi.azurewebsites.net/api/intervention/2


3. Returns all fields of all Service Request records that do not have a start date and are in "Pending" status.
   GET: api/intervention/pending                               
   https://localhost:5001/api/intervention/pending
   https://annachowattanakulapi.azurewebsites.net/api/intervention/pending
 
 
4. Change value of any parameters                              
   PUT: api/intervention/(id) 
   https://localhost:5001/api/intervention/2
   https://annachowattanakulapi.azurewebsites.net/api/intervention/2


5. Change the status of the intervention request to "InProgress" and add a start date and time (Timestamp).
   PUT: api/intervention/(id)/inProgress                       
   https://localhost:5001/api/intervention/2/inProgress 
   https://annachowattanakulapi.azurewebsites.net/api/intervention/2/inProgress
 
 
6. Change the status of the request for action to "Completed" and add an end date and time (Timestamp).
   PUT: api/intervention/{id}/completed                        
   https://localhost:5001/api/intervention/2/completed
   https://annachowattanakulapi.azurewebsites.net/api/intervention/2/completed




**Week 8 - Offer Services on the Internet** 

**Team:** 

>1. Ukeme Ekpenyong (Team Leader)
>2. Anna Chowattanakul
>3. Younes Bekkali
>4. David Hunter
>5. Jorge Chavarriaga

*To answer the 9 questions with [*Postman:](https://www.getpostman.com/collections/a5cd3bfab68ca5d11069)*
Click the Postman link if you want to import our collection into your Postman domain

1. Retrieving the current status of a specific **Battery**:

**GET:** https://rocketapi.azurewebsites.net/api/battery/69 - *(69 the battery id)* - **SEND**

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

To change the status: "status": "active" or "inactive"  and press **SEND**

Response:

**The status of the Battery Id: 69 has been changed to: inactive**
To review changes, refer to the first step.

3. Retrieving the current status of a specific **Column**:

**GET:** https://rocketapi.azurewebsites.net/api/column/69 - *(69 the battery id)* - **SEND**

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

To change the status: "status": "active" or "inactive"  and press **SEND**

Response:

**The status of the Column Id: 69 has been changed to: inactive**
To review changes, refer to the third step.

5. Retrieving the current status of a specific **Elevator**:

**GET:** https://rocketapi.azurewebsites.net/api/elevator/69 - *(69 the elevator id)* - **SEND**

6. Changing the status of a specific **Elevator**:

**PUT:** https://rocketapi.azurewebsites.net/api/elevator/69 - *(69 the elevator id)* 

Select: >Body >raw >JSON

{
    "id": 69,
    "column_id": 20,
    "status": "active"
}

To change the status: "status": "active" or "inactive"  and press **SEND**

Response:

**The status of the Elevator Id: 69 has been changed to: inactive**
To review changes, refer to the fifth step.

7. Retrieving a list of **Elevators** that are not in operation at the time of the request:

**GET:** https://rocketapi.azurewebsites.net/api/elevator/notinoperation - **SEND**

8. Retrieving a list of **Buildings** that contain at least one battery, column or elevator requiring intervention:

**GET:** https://rocketapi.azurewebsites.net/api/building/intervention - **SEND**

9. Retrieving a list of **Leads** created in the last 30 days who have not yet become customers:

**GET:** https://rocketapi.azurewebsites.net/api/lead/notcustomers - **SEND**

# <b>You can also use the following options:</b>
* https://rocketapi.azurewebsites.net/api/battery/all - To retrieve all the batteries availables
* https://rocketapi.azurewebsites.net/api/battery/active - To retrieve all the active batteries
* https://rocketapi.azurewebsites.net/api/battery/inactive - To retrieve all the inactive batteries 
* https://rocketapi.azurewebsites.net/api/column/all - To retrieve all the columns
* https://rocketapi.azurewebsites.net/api/column/active - To retrieve the active columns
* https://rocketapi.azurewebsites.net/api/column/inactive - To retrieve the inactive columns
* https://rocketapi.azurewebsites.net/api/building/all - To retrieve all the buildings
* https://rocketapi.azurewebsites.net/api/building/69 - To retrieve an specific building 
* https://rocketapi.azurewebsites.net/api/customer/all - To retrieve all the customers
* https://rocketapi.azurewebsites.net/api/lead/all - To retrieve all the leads
