using Exam.Models;

namespace Exam.Services;

public class PhoneService
{
    private List<Phone> phones;
    public PhoneService()
    {
        phones = new List<Phone>();
    }

    public Phone AddPhone(Phone restaurant)
    {
        restaurant.Id = Guid.NewGuid();
        phones.Add(restaurant);
        return restaurant;
    }

    public bool DeletePhone(Guid phoneId)
    {
        var exists = false;
        foreach (var phone in phones)
        {
            if (phone.Id == phoneId)
            {
                phones.Remove(phone);
                exists = true;
                break;
            }
        }

        return exists;
    }

    public bool UpdatePhone(Phone updatedRestaurant)
    {
        for (var i = 0; i < phones.Count; i++)
        {
            if (phones[i].Id == updatedRestaurant.Id)
            {
                phones[i] = updatedRestaurant;
                return true;
            }
        }

        return false;
    }

    public Phone GetById(Guid phoneId)
    {
        foreach (var phone in phones)
        {
            if (phone.Id == phoneId)
            {
                return phone;
            }
        }

        return null;
    }

    public List<Phone> GetAllPhones()
    {
        return phones;
    }
}

