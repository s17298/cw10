﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw10.DTOs.Requests;
using cw10.Models;
using cw10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentDbService _context;
        public StudentsController(IStudentDbService context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            IActionResult response;
            try
            {
                response = Ok(_context.GetStudents());
            } catch (Exception exc)
            {
                response = BadRequest("Blad przy zwracaniu studentow z bazy" + exc.StackTrace);
            }

            return response;
        }
        [HttpPost("modify")]
        public IActionResult ModifyStudent(ModifyStudentRequest request)
        {
            IActionResult response;
            try
            {
                _context.ModifyStudent(request);
                response = Ok("Pomyslnie zmodyfikowano studenta o indexie " + request.indexNumber);
            }
            catch (Exception exc)
            {
                response = BadRequest("Błąd przy modyfikowaniu studenta" + exc.StackTrace);
            }

            return response;
        }
        [HttpPost("delete")]
        public IActionResult DeleteStudent(DeleteStudentRequest request)
        {
            IActionResult response;
            try
            {
                _context.DeleteStudent(request);
                response = Ok("Pomyslnie usunieto studenta o indexie " + request.indexNumber);
            }
            catch (Exception exc)
            {
                response = BadRequest("Blad przy usuwaniu studenta" + exc.StackTrace);
            }

            return response;
        }
        [HttpPost("enroll")]
        public IActionResult EnrollStudents(EnrollStudentRequest request)
        {
            IActionResult response;
            try
            {
                response = Ok(_context.EnrollStudent(request));
            }
            catch (Exception exc)
            {
                response = BadRequest("Blad przy zapisywaniu studentow na studia" + exc.StackTrace);
            }

            return response;
        }
        [HttpPost("promote")]
        public IActionResult PromoteStudents(PromoteStudentRequest request)
        {
            IActionResult response;
            try
            {
                response = Ok(_context.PromoteStudents(request));
            }
            catch (Exception exc)
            {
                response = BadRequest("Blad przy promocji studentow" + exc.StackTrace);
            }

            return response;
        }
    }
}