using System;

namespace SufferShopLib
{
    public class CustomerSample
    {
        string firstName, middleName, lastName;
        string name;
        public String Name {
            get {
                return name;
            }
            set {
                // When set, the value input into the Name is split by the spaces to separate words.
                string[] strings = value.Split(' ');
                int numberOfWords = strings.Length; //TODO: This variable never mutates.
                if (strings[0].Length == 0) {
                    Console.WriteLine($"The length in words of the name of Customer #{ID} is 0.");
                    name = null;
                    return;
                }
                Console.WriteLine($"The length in words of the name of Customer #{ID} is {numberOfWords}."); //numberOfWords won't return 0.
                switch (numberOfWords) {
                    case 0: 
                        name = null;
                        break;
                    case 1: 
                        if (strings[0].Length == 0) {
                            name = null;
                            break;
                        }
                        firstName = strings[0];
                        middleName = null;
                        lastName = null;
                        name = firstName;
                        break;
                    case 2: 
                        firstName = strings[0];
                        middleName = null;
                        lastName = strings[1];
                        name = $"{firstName} {lastName}";
                        break;
                    default: 
                        firstName = strings[0];
                        for (int i = 1; i < strings.Length - 1; i++ ) {
                            middleName += strings[i];
                        }
                        lastName = strings[strings.Length - 1];
                        name = $"{firstName} {middleName} {lastName}";
                        break;
                }
                
                
            }
        }

        string email, password;//TODO: get user input for the email and password.


        int id;
        protected static int idIndex = 0;
        public int ID {
            get {
                return id;
            }
            set {
                int idIterator = value;
                if (value < 0) {
                    while (idIterator < idIndex) {
                        idIterator++;
                    }
                }
                id = idIterator;
            }
        }

        //TODO: Add Orders variable associated with the customer to the model

        string address,city,state,zipCode;//TODO: Add getters and setters for these
        string fullAddress;//TODO: Add getters and setters for this

        string phoneNumber;//TODO: Add getters and setters for this



        

        

        
        //TODO: Add constructors for Customer data
        public CustomerSample(string newName) {
            id = idIndex;
            idIndex++;
            Name = newName;
        }
    }
}
