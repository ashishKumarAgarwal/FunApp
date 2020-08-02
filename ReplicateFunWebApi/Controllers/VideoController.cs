using FunApp.Common.Models;
using FunApp.WebApI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FunApp.WebApI.Controllers
{
    [Route("api/Video")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoRepository _videoRepository;

        public VideoController(IVideoRepository videoRepository)

        {
            _videoRepository = videoRepository;
        }


        [HttpGet]
        public async Task<ActionResult> GetVideos()
        {
            try
            {
                return Ok(await _videoRepository.GetVideos());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetVideo(int id)
        {
            try
            {
                var video = await _videoRepository.GetVideo(id);
                if (video == null)
                {
                    return NotFound();
                }

                return Ok(video);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{subjectAreaId:int}")]
        public async Task<ActionResult> GetVideoBySubjectArea(int subjectAreaId)
        {
            try
            {
                var video = await _videoRepository.GetGetVideoBySubjectArea(subjectAreaId);
                if (video == null)
                {
                    return NotFound();
                }

                return Ok(video);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Video>> UpdateVideo(Video video)
        {
            try
            {
                var videoToUpdate = await _videoRepository.GetVideo(video.Id);

                if (videoToUpdate == null)
                {
                    return NotFound($"RetrospectionToUpdate with Id = {video.Id} not found");
                }

                return await _videoRepository.UpdateVideo(video);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

    }

}