﻿using ContactMangaer.Data.Entities.Base;

namespace ContactManager.DAL;
public class Contact : Entity
{
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public virtual List<EmailAddress> EmailAddresses { get; set; }
    public virtual List<Address> Addresses { get; set; }
    public string PrimaryEmail {  get; set; }
}


