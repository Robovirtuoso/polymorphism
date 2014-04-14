'polymorphism'
class HighCouncilController < ApplicationController
  def prepare_for_meeting(jedi)
    if jedi.is_palpatine? || jedi.is_apprentice_of_palpatine?
      SithInDisguisePresenter.new(jedi)
    elsif jedi.small_and_green?
      YodaPresenter.new(jedi)
    elsif jedi.class == Queen
      GuestPresenter.new(jedi)
    else
      jedi
    end
  end
end
