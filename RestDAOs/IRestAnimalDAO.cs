﻿using Model;

namespace RestDAOs;

public interface IRestAnimalDAO
{
    Task CreateAnimalAsync(Animal animal);
    Task DeleteAnimalAsync(string id);
}