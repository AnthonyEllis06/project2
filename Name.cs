//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Program 1 - NameList Class
//	File Name:		Name.cs
//	Description:	Defines the name class used to structure and create a name
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
//	Created:		Tuesday, Febuary 018, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DataStructures
{

    /// <summary>
    /// The Name Class is a class that can seperate a name into its various parts
    /// and can be compared by last name or first name.
    /// </summary>
    /// <seealso cref="System.IEquatable{DataStructures.Name}" />
    /// <seealso cref="System.IComparable{DataStructures.Name}" />
    /// <seealso cref="System.Collections.Generic.IComparer{DataStructures.Name}" />
    class Name : IEquatable<Name>, IComparable<Name>
    {
        #region Properites
        /// <summary>  property for the Rest of the name not Last or Suffix</summary>
        /// <value>String representation of the first name</value>
        public String Rest { get; set; }

        /// <summary>property for the names last name</summary>
        /// <value>string representation for the names last name</value>
        public String Last { get; set; }

        /// <summary>  property for the names suffix</summary>
        /// <value>  string representation of the suffix</value>
        public String Suffix { get; set; }

        /// <summary>  property for the names originial passed in value in the string constructor</summary>
        /// <value>  the string representation of the original name passed in</value>
        public String Original { get; set; }
        #endregion
        #region Constructors        
        /// <summary>
        /// Default constructor sets all props to null
        /// </summary>
        public Name()
        {
            Rest = null;
            Last = null;
            Suffix = null;
        }        
        /// <summary>
        /// Copy constructor to copy one name to another.
        /// </summary>
        /// <param name="NewName">A name object to Copy</param>
        public Name(Name NewName)
        {
            Rest = NewName.Rest;
            Last = NewName.Last;
            Suffix = NewName.Suffix;
            Original = NewName.Original;
        }        
        /// <summary>
        /// Name Constructor from String.
        /// </summary>
        /// <param name="NameParts">String name must be in American Format</param>
        public Name(String NameParts)
        {
            
            if (NameParts.Length <= 1)
                return;
            Original = NameParts; //sets original name value
            List<String> nameParts = new List<String>(Tools.Tokenize(NameParts," ")); //tokenizes name into multiple names

            #region Suffix
            String SuffixPattern = @"\b(([iIvV]+(?!\.))|([JR]r\.)|([PMJ].[dD]?))\Z";//pattern for suffix
            Match m = new Regex(SuffixPattern).Match(nameParts.Last<String>());//checks only last index of name array
            if (m.Success)
            {
                Suffix = nameParts.Last<String>();
                nameParts.RemoveAt(nameParts.Count-1);
                if (nameParts[nameParts.Count - 1] == ",")
                    nameParts.RemoveAt(nameParts.Count-1);
            }
            #endregion
            int CommaCount = 0;
            foreach(String part in nameParts)
            {
                if (part == ",")
                    CommaCount++;
            }
            if (CommaCount > 0)
            {
                int FirstCommaIndex = nameParts.IndexOf(",");
                Last = nameParts[FirstCommaIndex - 1];
                for (int i = 0; i < nameParts.Count; i++)
                {
                    if (i != FirstCommaIndex && i != FirstCommaIndex - 1)
                        Rest = Rest + nameParts[i] + " ";
                }
                Rest.Trim();
            }
            else
            {
                Last = nameParts.Last<String>();
                nameParts.RemoveAt(nameParts.Count - 1);
                for (int i = 0; i < nameParts.Count; i++)
                {
                    Rest = Rest + nameParts[i] + " ";
                }
                if(Rest!=null)
                    Rest.Trim();
            }

        }
        
        #endregion
        #region Methods
        /// <summary>
        /// Converts the Name to a String based on the format variable passed
        /// </summary>
        /// <returns>The Full String Representation of the Original Name</returns>
        public string NameToString()
        {
            return Original;
        }
        /// <summary> 
        /// Used to call NameToString in the First Name First Format
        /// </summary>
        /// <returns>Returns a String Representation of the name in the First name first format</returns>
        public String FirstNameFirst()
        {
            if (Suffix != null)
                return Rest + " " + Last + ", " + Suffix;
            return Rest + " " + Last;
        }

        /// <summary> 
        /// Used to call NameToString in the Last Name First Format
        /// </summary>
        /// <returns>>Returns a String Representation of the name in the Last name first format</returns>
        public String LastNameFirst()
        {
            if (Suffix != null)
                return Last + ", " +Rest+", " +Suffix;
            return Last + ", " + Rest;
        }
        #region IEquatable<Name> implementation
        /// <summary>
        /// Equality comparer for two Name objects
        /// </summary>
        /// <param name="other">  true if first and last names of this name are equal to Other.First and Other.Last, respectively</param>
        /// <returns>Boolean True if Equal and false if not equal</returns>
        bool IEquatable<Name>.Equals(Name other)
        {
            return (Rest.Equals(other.Rest) && Last.Equals(other.Last));
        }

        /// <summary>  Override of Object.Equals</summary>
        /// <param name="obj">  object to which this object is compared to.</param>
        /// <returns>Results from the Class Equals method</returns>
        /// <exception cref="ArgumentException">Cannot compare a Name and a obj object type.</exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return base.Equals(obj);//returns if object is equal
            if(!(obj is Name))
                throw new ArgumentException($"Cannot compare a Name and a {obj.GetType()} object.");
            return Equals(obj as Name);
        }

        /// <summary>  Overide of Object.GetHashCode</summary>
        /// <returns>Returns a hash code for this name object instance.</returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
        #region IComparable<Name> Implementation
        public int CompareTo(Name other)
        {
            if (!Last.Equals(other.Last))
                return Last.CompareTo(other.Last);
            return Rest.CompareTo(other.Rest);
        }

        public static int CompareByLast(Name one,Name two)
        {
            return one.Last.CompareTo(two.Last);
        }
        public static int CompareByFirst(Name one, Name two)
        {
            return one.Rest.CompareTo(two.Rest);
        }
        #endregion
        #endregion
    }

}
