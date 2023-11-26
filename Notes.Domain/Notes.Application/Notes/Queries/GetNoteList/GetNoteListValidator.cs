using System;
using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteList
{
	public class GetNoteListValidator : AbstractValidator<GetNoteListQuery>
	{
		public GetNoteListValidator()
		{
            RuleFor(note => note.UserId).NotEqual(Guid.Empty);
        }
	}
}

