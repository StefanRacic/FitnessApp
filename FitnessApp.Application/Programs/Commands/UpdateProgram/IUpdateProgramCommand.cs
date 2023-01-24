﻿using FitnessApp.Application.Programs.Queries.GetProgram;

namespace FitnessApp.Application.Programs.Commands.UpdateProgram
{
    public interface IUpdateProgramCommand
    {
        Task<ProgramModel> Execute(int id, UpdateProgramModel model);
    }
}
