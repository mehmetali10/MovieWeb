using MovieWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using MovieWeb.Data;

public class HomeController : Controller
{
    

    public IActionResult Index(int? id)
    {
       // var model = new ProductCategoryModel();
        //model.Categories = CategoryRepository.Categories;
        //model.Movies = MovieRepository.Movies;
        var movies = MovieRepository.Movies;
        if(id != null) {
            movies = movies.Where(i => i.CategoryId== id).ToList();
        }
        return View(movies);
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Details(int Id)
    {
        //var model = new ProductCategoryModel();
        //model.Categories = CategoryRepository.Categories;
        //model.Movie = MovieRepository.GetById(Id); 
        return View(MovieRepository.GetById(Id));
    }
}
