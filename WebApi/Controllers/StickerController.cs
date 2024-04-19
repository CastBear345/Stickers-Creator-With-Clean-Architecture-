using Application.Contracts;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/stickers")]
public class StickerController(StickerService stickerService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Add(CreateStickerRequest request)
    {
        await stickerService.CreateAsync(request);

        return Ok();
    }
}
