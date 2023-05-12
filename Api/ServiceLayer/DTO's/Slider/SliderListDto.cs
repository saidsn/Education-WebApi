namespace ServiceLayer.DTOs.Slider
{
    public class SliderListDto
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
