// Controllers/LancamentoController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExtratoContaCorrente.Data;
using ExtratoContaCorrente.Models;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class LancamentoController : ControllerBase
{
    private readonly AppDbContext _context;

    public LancamentoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IQueryable<Lancamento>>> GetLancamentos()
    {
        var lancamentos = await _context.Lancamentos.ToListAsync();
        return Ok(lancamentos);
    }

    [HttpPost]
    public async Task<ActionResult<Lancamento>> PostLancamento(Lancamento lancamento)
    {
        _context.Lancamentos.Add(lancamento);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetLancamentos), new { id = lancamento.Id }, lancamento);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutLancamento(int id, Lancamento lancamento)
    {
        if (id != lancamento.Id)
        {
            return BadRequest();
        }

        _context.Entry(lancamento).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!LancamentoExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLancamento(int id)
    {
        var lancamento = await _context.Lancamentos.FindAsync(id);
        if (lancamento == null)
        {
            return NotFound();
        }

        _context.Lancamentos.Remove(lancamento);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool LancamentoExists(int id)
    {
        return _context.Lancamentos.Any(e => e.Id == id);
    }
}
