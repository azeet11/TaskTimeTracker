using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskTimeTracker.Entities;
using TaskTimeTracker.EntityFrameworkCore;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace TaskTimeTracker;

public class UserAppService : ApplicationService
{
    private readonly IRepository<User, Guid> _userRepository;
    private readonly IGuidGenerator _guidGenerator;

    public UserAppService(IRepository<User, Guid> userRepository, IGuidGenerator guidGenerator)
    {
        _userRepository = userRepository;
        _guidGenerator = guidGenerator;
    }
}