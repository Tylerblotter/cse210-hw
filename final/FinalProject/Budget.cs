class Budget
    {
        private string name;
        private List<Category> categories = new List<Category>();

        public Budget(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public Category GetCategory(string name)
        {
            foreach (Category category in categories)
            {
                if (category.Name == name)        
                    {
                    return category;
                    }
                    }
                    return null;
        }

    internal decimal GetNetBalance()
    {
        throw new NotImplementedException();
    }
}
