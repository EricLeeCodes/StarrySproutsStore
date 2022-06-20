<h1>Mock e-commerce website!</h1>

<h2>Walk Through</h2>

This project was created using Asp.NET Core MVC(Model-View-Controller).
HTML, CSS, Bootstrap, and C# was used to create the project.
Entity Framework was used with SQL Server to store the data.

![Web capture_19-6-2022_191710_localhost](https://user-images.githubusercontent.com/87954849/174505866-6e2803c2-975d-45b9-aef2-377700b49c61.jpeg)

The front page has a revolving carousel that switches between 4 clickable pictures that leads to the products.

![Web capture_19-6-2022_192157_localhost](https://user-images.githubusercontent.com/87954849/174506076-f17c5c02-1333-49e7-8680-b444d3402a5a.jpeg)

The product page features clickable bootstrap cards that links the user to a detailed description of the product.

![Web capture_19-6-2022_192339_localhost](https://user-images.githubusercontent.com/87954849/174506136-5dfb6a69-5982-43e4-ab0e-8bc3fd7639d3.jpeg)

The "Add to Cart" button redirects the user to the Shopping Cart where the Amount, Item name, and Price with the Subtotal is displayed.
Here we can decrease the amount (or remove the item if it is 1), Continue Shopping (redirects back to the products page), Clear Cart, or Checkout.

![Web capture_19-6-2022_192843_localhost](https://user-images.githubusercontent.com/87954849/174506347-5ef2fd4b-d9b8-430f-acba-feb4da781ab2.jpeg)

When the user Checks Out their items, an account is asked to be created so that the order can be paired with the Order.
You can Log In or Create an account.
After logging in, we are asked to fill out shipping details. It also has validation to make sure each box is filled out correctly.

![Web capture_19-6-2022_193115_localhost](https://user-images.githubusercontent.com/87954849/174506505-f559794d-b0ac-4a7b-aa38-2091c53d872f.jpeg)
![Web capture_19-6-2022_193926_localhost](https://user-images.githubusercontent.com/87954849/174506809-76ce5b04-ead0-4d50-88d5-c16131662a97.jpeg)

Now we can see that the order is completed.

![Web capture_19-6-2022_193514_localhost](https://user-images.githubusercontent.com/87954849/174506651-8b10af3b-c3be-4d96-84c8-0106a45e9ebf.jpeg)

If we go back to our database, we can see that the order was successfully created as well.

![Screenshot 2022-06-19 193816](https://user-images.githubusercontent.com/87954849/174506775-9e5d3fc5-a4b5-46b4-83b1-3a6f0d38b4af.png)
