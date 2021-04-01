namespace BlazorServerExample.Data {
    public class UserDataService {
        public string Name { get; set; }

        public uint ComponentLoadCount { get; set; } = 0;

    }
}