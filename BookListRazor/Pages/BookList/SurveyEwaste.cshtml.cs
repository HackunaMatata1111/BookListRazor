using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class SurveyEwasteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public SurveyEwasteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public SurveyEwaste SurveyEwaste { get; set; }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                
                SurveyEwaste surveyewaste = new SurveyEwaste();
                if (Request.Form["Question1"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question1"].ToString();


                    surveyewaste.question = 101;
                    surveyewaste.option = selectedGender;
                    //surveyewaste.UserId= DonateEwaste.id

                }
                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question2"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question2"].ToString();



                    surveyewaste.question = 102;
                    surveyewaste.option = selectedGender;




                }
                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question3"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question3"].ToString();


                    surveyewaste.question = 103;
                    surveyewaste.option = selectedGender;




                }
                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question4"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question4"].ToString();


                    surveyewaste.question = 104;
                    surveyewaste.option = selectedGender;



                }

                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question5"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question5"].ToString();


                    surveyewaste.question = 105;
                    surveyewaste.option = selectedGender;



                }

                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question6"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question6"].ToString();


                    surveyewaste.question = 106;
                    surveyewaste.option = selectedGender;



                }

                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question7"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question7"].ToString();


                    surveyewaste.question = 107;
                    surveyewaste.option = selectedGender;



                }

                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question8"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question8"].ToString();


                    surveyewaste.question = 108;
                    surveyewaste.option = selectedGender;



                }

                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question9"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question9"].ToString();


                    surveyewaste.question = 109;
                    surveyewaste.option = selectedGender;



                }

                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                surveyewaste = new SurveyEwaste();
                if (Request.Form["Question10"] != string.Empty)
                {
                    string selectedGender = Request.Form["Question10"].ToString();

                    surveyewaste.question = 1010;
                    surveyewaste.option = selectedGender;



                }

                await _db.SurveyEwaste.AddAsync(surveyewaste);
                await _db.SaveChangesAsync();

                return RedirectToPage("SelectEwaste");

            }
            else
            {
                return Page();
            }
        }

    }
}

