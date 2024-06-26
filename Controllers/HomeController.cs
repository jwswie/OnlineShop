﻿using Microsoft.AspNetCore.Mvc;
using ASPNETMVCProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASPNETMVCProject.Controllers
{
    public class HomeController : Controller
    {

        List<Product> products = new List<Product>
        {
            new Product("Beach Dress", 100, "images/01.jpg", "Yellow-Dress",
                description1 : "Explore sunny shores in style with our radiant yellow beach dress",
                description2 : "This enchanting piece effortlessly captures the essence of summer with its flowing silhouette and vibrant hue",
                description3 : "Crafted with lightweight fabric, it offers both comfort and elegance, perfect for leisurely strolls along the coastline or lounging under the sun. Its flattering design, adorned with delicate details, accentuates your femininity, making it a must-have addition to your beachwear collection",
                description4 : "Embrace the warmth of the season and bask in the joy of seaside adventures with this chic yellow beach dress"),
            new Product("Beach Sun Hat", 20, "images/02.jpg", "Red-Hat",
                description1 : "Elevate your beach ensemble with our stunning red sun hat, the perfect accessory for your summer escapades",
                description2 : "Its vibrant red hue adds a pop of color to any outfit, making it a standout piece by the shore",
                description3 : "Crafted with breathable materials, this chic hat combines style with functionality, shielding you from the sun's rays while exuding effortless charm. Whether you're lounging by the pool or strolling along the sandy shores, this beach hat promises to keep you cool and fashionable",
                description4 : "Embrace the warmth of the season with confidence and flair in our red sun hat, a quintessential addition to your summer wardrobe"),
            new Product("Air Mattress", 30, "images/03.jpg", "Yellow-Mattress",
                description1 : "Dive into relaxation with our vibrant yellow pool air mattress",
                description2 : "Its eye-catching yellow color adds a cheerful touch to any aquatic setting, making it a standout accessory for soaking up the sun",
                description3 : "Crafted for endless summer fun, this mattress promises to elevate your lounging experience with its sunny charm and comfortable design. Made from durable, high-quality materials, it ensures hours of enjoyment in the pool or at the beach without compromising on support",
                description4 : "Whether you're drifting lazily in the pool or catching waves at the beach, our yellow inflatable mattress is your ticket to ultimate relaxation and summer bliss"),
            new Product("Sunglasses", 10, "images/04.jpg", "Yellow-Sunglasses",
                description1 : "Shield your eyes in style with our chic yellow sunglasses",
                description2 : "The bold yellow frames exude a playful vibe, perfect for soaking up the sun at the beach or sipping cocktails by the pool",
                description3 : "Designed to add a pop of color to your summer look, these sunnies not only offer 100% UV protection but also elevate your fashion game effortlessly. The tinted lenses not only reduce glare but also provide clarity and comfort under the bright sunlight",
                description4 : "Whether you're lounging seaside or exploring a bustling boardwalk, these yellow sunglasses are the perfect blend of fashion and function for all your sunny adventures"),
            new Product("Beach Sun Hat", 30, "images/05.jpg", "Yellow-Hat",
                description1 : "Elevate your beach ensemble with our stunning yellow sun hat, the perfect accessory for your summer escapades",
                description2 : "Its vibrant yellow hue adds a pop of color to any outfit, making it a standout piece by the shore",
                description3 : "Crafted with breathable materials, this chic hat combines style with functionality, shielding you from the sun's rays while exuding effortless charm. Whether you're lounging by the pool or strolling along the sandy shores, this beach hat promises to keep you cool and fashionable",
                description4 : "Embrace the warmth of the season with confidence and flair in our yellow sun hat, a quintessential addition to your summer wardrobe")
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductPage(int index)
        {
            var selectedProduct = products.ElementAtOrDefault(index);
            return View(selectedProduct);
        }
    }
}
