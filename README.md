# What is ParseTo

Parse To was a project first conceptualized as a way to commonly handle nulls but soon moved into a generic Parser to take an object variable and turn it into a generically passed type, a built in default for the type or a passed default for the type. 

It does this by using an IParse<> interface that creates a handler for the type you wish to cast to or resturns an Exception if the type has not IParse<> impelmentation

## Current Functionality

### Custom parsable types

To build custom parsable type inherit a handler class or actual parsable object class from the IParse<[ObjectClassName]>(Must have a blank constructor) and implement the interface. Its as simple as that you class can now be parsed

For Example:

    public TestObject : IParse<TestObject>
    {
        public string Name { get; set; }
        
        public TestObject Parse(object i)
        {
            if(i is string)
                return new TestObject() { Name = i };
            return (TestObject)i;
        }

        public TestObject GetDefault()
        {
            return new TestObject();
        }
    }    
> build the class and inhrit from IParse<>(Must have a blank constructor)

    public void TestMethod(string obj = "blank")
    {
        var testObject = obj.ParseTo<TestObject>();
        
> Now you can parse to your test object

### Pre-built parsable types
#### int
*Default return: 0*
#### int?
*Default return: null*
#### string
#### double
#### long
#### float
#### decimal
#### Guid
#### bool
#### bool?
#### DateTime
#### DateTime?
  
# Contribute

Come conribute would love to hear you ideas [Contribute](https://github.com/SamB1990/ParseTo/blob/master/CONTRIBUTING.md)

# Issues

Got an issue here are my [guidelines](https://github.com/SamB1990/ParseTo/blob/master/CONTRIBUTING.md#issues) for reporting it.

# License

This work is licensed under a [MIT License](https://github.com/SamB1990/ParseTo/blob/master/LICENSE)

# Code of Conduct

This repository contains the Open Source [Code of Conduct](https://github.com/SamB1990/ParseTo/blob/master/CODE_OF_CONDUCT.md)

