# CryptoWar
CryptoWar is a class library that wraps the Rijndael Algorithm in a Password crypto utility class. It's developed in C#. It also ships an utility for auto generate passwords. It is an implementation of the Advanced Encryption Standard (AES) adopted by the US government.

## Nuget
You can find this library as a Nuget package: 	http://warnov.com/@CryptoWarNuget
        
        PM> Install-Package AESManagedWrapper -Version 1.0.0
 

How to Use It:
-----------

Just add a reference to

    WarNov.RijndaelManagedWrapper

and call the statics methods:

    //Encryption
    var encTxt = RMWCrypto.EncryptStringAES(txt, ss);
    //Decryption     
    var decTxt = RMWCrypto.DecryptStringAES(encTxt, ss);    

The first parameter received is the text to work with. The second is the string with the shared key to work with.

The class PasswordGenerator is also included and with that class you can build passwords automatically (or strong shared-secrets for your encryptions), specifying the amount of characters, the characters to be used, and the possibility of have repetitions in the characters or not.
You can use this class in this way:

  

    private void btnAutogenerate_Click(object sender, EventArgs e)    
    {
    	int value = (int)nudMain.Value;
        PasswordGenerator pg = new PasswordGenerator()
        {
                ConsecutiveCharacters = true,
                Maximum = value,    
                Minimum = value - 1,    
                RepeatCharacters = true    
        };
        txtSS.Text = pg.Generate();
    }

There are also sample projects included for you to learn how to use the library.
<!--stackedit_data:
eyJoaXN0b3J5IjpbMTc4MjE5NzA1Nl19
-->