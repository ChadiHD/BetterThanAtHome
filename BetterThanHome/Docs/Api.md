# Buber Breakfast API

- [BetterThanHome API](#buber-breakfast-api)
  - [Create Order](#create-order)
    - [Create Breakfast Request](#create-breakfast-request)
    - [Create Breakfast Response](#create-breakfast-response)
  - [Get Breakfast](#get-breakfast)
    - [Get Breakfast Request](#get-breakfast-request)
    - [Get Breakfast Response](#get-breakfast-response)
  - [Update Breakfast](#update-breakfast)
    - [Update Breakfast Request](#update-breakfast-request)
    - [Update Breakfast Response](#update-breakfast-response)
  - [Delete Breakfast](#delete-breakfast)
    - [Delete Breakfast Request](#delete-breakfast-request)
    - [Delete Breakfast Response](#delete-breakfast-response)

## Create Order

### Create Order Request

```js
POST /Orders/{{id}}
```

```json
{
    "deliveryAddress": "27 New Barm",
    "dateOfDelivery": "2022-12-16T10:58:15.936Z",
    "orderList": [
        {
            "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
            "orderStatus": "Preparing order!",
            "orderDate": "2022-12-16T10:58:15.936Z",
            "guestsNumber": 1,
            "guests": [
                {
                    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                    "firstName": "chad",
                    "lastName": "hammoud",
                    "email": "rolmon12dda@yahoo.com",
                    "phoneNr": 099223141,
                    "location": "27 new barn"
                }
            ],
            "staffMembers": [
                {
                    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                    "firstName": "tim",
                    "lastName": "buratu",
                    "email": "tim.Bur@yahoo.com",
                    "phoneNr": 0235252,
                    "dateOfEmployment": {
                        "year": 2022,
                        "month": 12,
                        "day": 11,
                        "dayOfWeek": 0
                    },
                    "salary": 1200
                }
            ],
            "dishes": [
                {
                    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                    "dishName": "Yaki Soba",
                    "dishType": "Chinese",
                    "price": 10,
                    "prepTime": "2022-12-16T10:58:15.936Z"
                }
            ]
        }
    ]
}

```

### Create Breakfast Response

```js
201 Created
```

```yml
Location: {{host}}/Breakfasts/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get Breakfast

### Get Breakfast Request

```js
GET /breakfasts/{{id}}
```

### Get Breakfast Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update Breakfast

### Update Breakfast Request

```js
PUT /breakfasts/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update Breakfast Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Breakfasts/{{id}}
```

## Delete Breakfast

### Delete Breakfast Request

```js
DELETE /breakfasts/{{id}}
```

### Delete Breakfast Response

```js
204 No Content
```