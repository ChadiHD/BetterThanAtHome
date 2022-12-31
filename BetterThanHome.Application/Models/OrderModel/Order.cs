using BetterThanHome.Contracts._Order;
using System.Runtime.InteropServices;
using BetterThanHome.Contracts;

namespace BetterThanHome.Application.Models.OrderModel;

public class Order
{
    public Guid Id { get; }
    public string OrderStatus { get; }
    public DateTime OrderDate { get; }
    public int GuestsNumber { get; }
    public List<Guest> Guests { get; }
    public List<Staff> StaffMembers { get; }
    public List<Dish> Dishes { get; }

    public Order(
        Guid id,
        string orderStatus,
        DateTime orderDate,
        int guestsNumber,
        List<Guest> guests,
        List<Staff> staffMembers,
        List<Dish> dishes)
    {
        Id = id;
        OrderStatus = orderStatus;
        OrderDate = orderDate;
        GuestsNumber = guestsNumber;
        Guests = guests;
        StaffMembers = staffMembers;
        Dishes = dishes;
    }

    private static Order Create(
        string orderStatus,
        DateTime orderDate,
        int guestsNumber,
        List<Guest> guests,
        List<Staff> staffMembers,
        List<Dish> dishes,
        Guid? id = null)
    {
        return new Order(
            id ?? Guid.NewGuid(),
            orderStatus,
            orderDate,
            guestsNumber,
            guests,
            staffMembers,
            dishes);
    }

    public static Order From(Guid id, UpsertOrderRequest request)
    {
        return Create(
            request.OrderStatus,
            request.OrderDate,
            request.GuestsNumber,
            request.Guests,
            request.StaffMembers,
            request.Dishes,
            id);
    }

    public static Order From(CreateOrderRequest request)
    {
        return Create(
            request.OrderStatus,
            request.OrderDate,
            request.GuestsNumber,
            request.Guests,
            request.StaffMembers,
            request.Dishes);
    }
}
