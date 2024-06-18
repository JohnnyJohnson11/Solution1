using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using SystemFile = System.IO.File;
using TubesKPL_WorkersUnion;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class PenggunaController : ControllerBase
{
    private readonly ILogger<PenggunaController> _logger;
    private readonly List<Pengguna> _penggunaList; // This should be replaced with a proper data store or repository
    
    public PenggunaController(ILogger<PenggunaController> logger)
    {
        _logger = logger;
        _penggunaList = new List<Pengguna>(); // Initialize with sample data or inject a data repository
        string hasilBaca = SystemFile.ReadAllText(@"C:\Users\Sean Himawan Arianto\source\repos\Solution1\GUI_Form\bin\Debug\net6.0-windows\login_config.json");
        Config ListPengguna = JsonSerializer.Deserialize<Config>(hasilBaca);
        for (int i = 0; i < ListPengguna.pengguna.Count; i++)
        {
            _penggunaList.Add(ListPengguna.pengguna[i]);
        }
    }

    [HttpPost]
    public IActionResult CreatePengguna([FromBody] Pengguna pengguna)
    {
        _logger.LogInformation("Pengguna created: {@pengguna}", pengguna);
        return CreatedAtAction(nameof(GetPenggunaByUsername), new { username = pengguna.username }, pengguna);
    }

    [HttpGet("Cari Pengguna")]
    public IActionResult GetPenggunaByUsername(string username)
    {
        var pengguna = _penggunaList.FirstOrDefault(p => p.username == username);
        if (pengguna == null)
        {
            return NotFound();
        }

        return Ok(pengguna);
    }
    [HttpGet("Tunjukkan Semua Pengguna")]
    public IActionResult TunjukkanSemuaData()
    {
        return Ok(_penggunaList);
    }

    // Other actions like UpdatePengguna, DeletePengguna, etc.
}
