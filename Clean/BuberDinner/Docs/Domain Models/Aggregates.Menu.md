# Domain Models

## Menu

```csharp
class Menu 
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
}
```

```json
{
    "id":"0000-000-000000-00000-00",
    "name":"Yummy",
    "description":"Yummy foood",
    "averageRating":4.5,
    "sections": [{
        "id":"0000-000-000000-00000-00",
        "name":"Ape",
        "description":"Yummy apet",
        "items":[
            {
                "id":"0000-000-000000-00000-00",
            "name":"Fried Potatoes",
            "description":"Deep fried potatoes",
            "price":5.99
            }
        ]
    }],
    "createdDateTime": "2020-01-01-T00:00:00.0000000Z",
    "updatedDateTime": "2020-01-01-T00:00:00.0000000Z",
    "hostId":"0000-000-000000-00000-00",
    "dinnerIds": ["0000-000-000000-00000-00", "0000-000-000000-00000-00"],
    "menuReviewIds":["0000-000-000000-00000-00","0000-000-000000-00000-00"],

}
```

